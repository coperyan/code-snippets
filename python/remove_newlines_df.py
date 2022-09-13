import pandas as pd


def clean_df(df: pd.DataFrame = None):
    """DF will be passed
    Will check each col for \n and \r
    """
    for col in df.columns.values:
        try:
            if (
                len(df[df[col].str.contains(r"\n") == True]) > 0
                or len(df[df[col].str.contains(r"\r") == True]) > 0
            ):
                df[col] = df[col].str.replace(r"\n", "", regex=True)
                df[col] = df[col].str.replace(r"\r", "", regex=True)
        except:
            pass

    return df
