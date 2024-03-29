﻿using Azure.Storage.Blobs;
using JobManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace JobManager.Services
{
    class BlobStorageServiceAzure : IBlobStorageService
    {

        //Related Documentation:
        //https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet
        //https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-xamarin
        //https://docs.microsoft.com/en-us/visualstudio/data-tools/how-to-save-and-edit-connection-strings?view=vs-2019

        private readonly BlobServiceClient service = new BlobServiceClient(ConnectionString);

        private static string ConnectionString => "DefaultEndpointsProtocol=https;AccountName=isp1004example;AccountKey=m2fGXOU8vUMOr/hCp7YGfBFcwyb1vYZKXLXO0GrsDyuMnZkOyYsSgJCUA/D5XgpTKcyAjHTxuTl5+AStkc5gVQ==;EndpointSuffix=core.windows.net";
        private static string Container => "A00244354";

        public async Task<MemoryStream> DownloadStreamAsync(string name)
        {
            BlobClient blob = service.GetBlobContainerClient(Container).GetBlobClient(name);

            if (blob.Exists())
            {
                var stream = new MemoryStream();
                await blob.DownloadToAsync(stream);

                stream.Position = 0;
                return stream;
            }

            return null;
        }

        public async Task UploadStreamAsync(string name, MemoryStream stream)
        {
            stream.Position = 0;
            BlobClient blob = service.GetBlobContainerClient(Container).GetBlobClient(name);
            await blob.UploadAsync(stream);
        }
    }
}