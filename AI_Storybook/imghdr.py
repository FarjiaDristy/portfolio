"""Minimal shim for missing stdlib imghdr module in Python 3.13 environment.
Streamlit tries to import this module; if it's absent Streamlit fails to load.
This stub returns None for any input, which disables image type detection but
keeps Streamlit running.
"""


def what(file, h=None):
    """Return the image type based on the file header.
    Always returns None in this stub implementation.
    """
    return None
