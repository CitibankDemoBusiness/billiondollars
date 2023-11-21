import gdown

# URL to the model
url = "https://drive.google.com/u/0/uc?id=1LufhOF7wf92-wVUU0kkYsIaBM4Ho_6AV"

# Output file name
output = "/content/financial_assistant.onnx"

# Limit download speed to 1 MB/s (you can adjust this value)
t.download(url, output)
from googleapiclient.discovery import build
from oauth2client.client import GoogleCredentials
import io
import os
import onnx

def authenticate_with_google_drive():
    """Authenticates with the Google Drive API.

    Returns:
        A Google Drive service object.
    """

    credentials = GoogleCredentials.get_application_default()
    drive_service = build('drive', 'v3', credentials=credentials)

    return drive_service

def download_file_from_drive(file_id, drive_service):
    """Downloads a file from Google Drive.

    Args:
        file_id: The ID of the file to download.
        drive_service: A Google Drive service object.
    """

    # Get the file metadata.
    file_metadata = drive_service.files().get(fileId=file_id).execute()

    # Download the file.
    file_data = drive_service.files().get_media(fileId=file_id).execute()

    # Save the file to disk.
    with open('onnx_model.onnx', 'wb') as f:
        f.write(file_data)

if __name__ == '__main__':
    # Authenticate with the Google Drive API.
    drive_service = authenticate_with_google_drive()

    # Download the ONNX model from Google Drive.
    download_file_from_drive('1LufhOF7wf92-wVUU0kkYsIaBM4Ho_6AV', drive_service)

    # Load the ONNX model.
    onnx_model = onnx.load('onnx_model.onnx')

    # Do something with the ONNX model.
    print(onnx_model.graph)
