import os
import googlemaps

address = "123 Any Way, Test, CA 94591"
gmaps_client = googlemaps.Client(key=os.environ.get("GMAPS_API_KEY"))


def geocode_address(address):
    resp = gmaps_client.geocode(address)
    return tuple(map(resp[0]["geometry"]["location"].get, ["lat", "lng"]))
