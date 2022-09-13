import json
from google.cloud import bigquery


def process_gcp_schema(fp: str = None):
    """Pass the file path to a GCP schema JSON
    [{"name":"Col","type":"STRING","mode":"NULLABLE"}]
    Read in, create bigquery.SchemaField objects from each, mapping keys as params
    """
    with open(fp, "r") as f:
        sf = json.load(f)

    sch = [bigquery.SchemaField(**x) for x in sf]
    return sch
