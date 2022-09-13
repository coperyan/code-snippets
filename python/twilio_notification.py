import os
from twilio.rest import Client

PHONE_TO = "+17079808746"

TW_CLIENT = Client(os.environ.get("TWILIO_SID"), os.environ.get("TWILIO_TOKEN"))


def send_notification(msg: str = None, addl: str = None):
    """Creates twilio client
    Sends message, appends exception detail if exists
    """
    TW_CLIENT.client.api.account.messages.create(
        to=PHONE_TO,
        from_=os.environ.get("TWILIO_PHONE"),
        body=msg + "\n\n" + addl if addl else msg,
    )
