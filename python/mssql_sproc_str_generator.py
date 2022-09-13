def sproc_query(db: str = None, schema: str = None, sp: str = None, **kwargs):
    """Params: db (database), schema (schema), sp (stored procedure name), kwargs map to parameters"""
    q = (
        "EXECUTE "
        + (f"{db}." if db else "")
        + (f"{schema}." if schema else "")
        + (f"{sp}")
    )
    if kwargs:
        ctr = 0
        for k, v in kwargs.items():
            ctr += 1
            q = (
                f"{q} @{k} = "
                + (f"'{v}'" if type(v) == str else f"{v}")
                + ("," if ctr < len(kwargs) else "")
            )

    q = f"{q};"
    return q
