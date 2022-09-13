BEGIN

    --Delete records that already exist & have been updated
    DELETE FROM `{gcp_dataset}.{table}`
    WHERE (`{uuid}`) in (
        SELECT `{uuid}`
        FROM `{gcp_staging_dataset}.{table}`
    );

    --Insert all new records
    INSERT INTO `{gcp_dataset}.{table}`
    SELECT *
    FROM `{gcp_staging_dataset}.{table}`;

    --Delete staging table
    DROP TABLE `{gcp_staging_dataset}.{table}`;


END;