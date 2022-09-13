import os
from airflow import DAG
from airflow.models import Variable
from airflow.utils.task_group import TaskGroup
from airflow.operators.dummy_operator import DummyOperator
from datetime import datetime, timedelta, time

default_args = {
    "start_date": datetime(2022, 8, 4),
    "catchup": False,
    "retries": 0,
}

ITERATIONS = ["table_1", "table_2", "table_3"]

with DAG(
    f"TEST_ingestion",
    schedule_interval="0 7 * * *",
    default_args=default_args,
) as dag:

    start = DummyOperator(task_id="start")
    end = DummyOperator(task_id="end")
    loop_start = DummyOperator(task_id="loop_start")
    loop_end = DummyOperator(task_id="loop_end")

    with TaskGroup(group_id="ingestion_process") as ingestion:

        for iter in ITERATIONS:

            with TaskGroup(group_id=f"{iter}") as tg1:

                ingest_1 = DummyOperator(task_id=f"{iter}_ingest_1")
                ingest_2 = DummyOperator(task_id=f"{iter}_ingest_2")

                loop_start >> ingest_1 >> ingest_2 >> loop_end

    start >> loop_start >> loop_end >> end
