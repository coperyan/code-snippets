def get_dayofweek():
    #Returns day of the week
    list = [
    'Sunday','Monday','Tuesday',
    'Wednesday','Thursday','Friday',
    'Saturday'
    ]
    #Returns integer for day # of week - starting with sunday at 0
    dayint = int(dt.datetime.today().strftime('%w'))
    return list[dayint]
