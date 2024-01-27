import re


def extract_lat_long_from_url(url):
    """
    Extract latitude and longitude from a Google Maps URL.

    :param url: Google Maps URL as a string.
    :return: A tuple containing latitude and longitude as strings, or (None, None) if not found.
    """
    regex = r"@([0-9.-]+),([0-9.-]+)"
    match = re.search(regex, url)
    if match:
        latitude, longitude = match.groups()
        return latitude, longitude
    else:
        return None, None

long_url = 'https://www.google.com/maps/place/15%C2%B04327.0%22N+79%C2%B01559.8%22E/@15.7241611,79.2640343,17z/data=!3m1!4b1!4m4!3m3!8m2!3d15.7241611!4d79.2666092?entry=ttu'

lat, long = extract_lat_long_from_url(long_url)
print(lat, long);
