import pandas as pd


class Example:
    def __init__(self, **kwargs):
        self.__dict__.update(kwargs)

    def get_dict(self):
        return self.__dict__

    def get_df(self, fields: list = None) -> pd.DataFrame:
        """fields = list of class properties"""
        d = self.__dict__
        if fields:
            df = pd.json_normalize({k: v for k, v in d.items() if k in fields})
            return df
        else:
            try:
                df = pd.json_normalize(self.__dict__)
                return df
            except Exception as e:
                print(e)
