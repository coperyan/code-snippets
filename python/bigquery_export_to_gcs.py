from google.cloud import bigquery
from google.api_core.exceptions import BadRequest


def export_bq_to_gcs(gcs_bucket, gcs_path, project, dataset, table, location="US"):
    """GCS bucket ID, path in bucket (eg extracts/etc)
    BQ project, BQ dataset, BQ table name"""
    bq_client = bigquery.Client()
    try:
        ext = bq_client.extract_table(
            bigquery.DatasetReference(project, dataset).table(table),
            f"gs://{gcs_bucket}/{gcs_path}/{project}_{dataset}_{table}.csv",
            location=location,
        )
        ext.result()
    except BadRequest as ex:
        for err in ex.errors:
            print(f"Export error: {err}")
