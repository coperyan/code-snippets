import decimal
import datetime


def convert_type(v):
    """Converts values when writing to NL JSON"""
    if isinstance(v, decimal.Decimal):
        return float(v)
    if isinstance(v, (datetime.date, datetime.time)):
        return v.isoformat()
    return v
