import requests
import colors

# Public configuration options
import configuration
# Private configuration options
import credentials

# Test Components

def get(session, url):
    response = session.get(url)
    return response

def post(session, url, resource):
    response = session.post(url, resource)
    return response

def postAsJson(session, url, resource):
    response = session.post(url, json=resource)
    return response

def put(session, url, resource):
    response = session.put(url, resource)
    return response

def putAsJson(session, url, resource):
    response = session.put(url, json=resource)
    return response

def delete(session, url):
    response = session.delete(url)
    return response


# Test Case Base Class

TEST_PASS = "PASS"
TEST_FAIL = "FAIL"







