def read_file(p, **kwargs):
    """Reads file and attempts to format_map with kwargs"""
    with open(p) as f:
        filestr = "".join([l for l in f])
    return filestr.format_map(kwargs)
