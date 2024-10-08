﻿using System;
using System.IO;
using System.Text;
using biz.admin.Repository.Utility;
using System.Collections.Generic;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace dal.admin.Repository.Utility
{
    public class UtilityRepository : IUtilityRepository
    {
        public string CompressString(string text)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream();
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gZipStream.Write(buffer, 0, buffer.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return Convert.ToBase64String(gZipBuffer);
        }

        public string DecompressString(string compressedText)
        {
            byte[] gZipBuffer = Convert.FromBase64String(compressedText);
            using (var memoryStream = new MemoryStream())
            {
                int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                var buffer = new byte[dataLength];

                memoryStream.Position = 0;
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gZipStream.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }

        public string UploadImageBase64(string image, string ruta, string _extension)
        {
            //string ruta;

            var filePath = Environment.CurrentDirectory;
            var extension = _extension;
            var _guid = Guid.NewGuid();
            var path = ruta + _guid + "." + extension;

            var bytes = Convert.FromBase64String(image);
            using (var imageFile = new FileStream(filePath + "/" + path, FileMode.Create))
            {
                imageFile.Write(bytes, 0, bytes.Length);
                imageFile.Flush();
            }

            //ruta = selRuta.Url + _guid + "." + extension;
            return path;
        }

        public async Task<string> UploadFile(IFormFile file)
        {
            var filePath = Environment.CurrentDirectory;
            var path = "Files/" + file.FileName;
            using (Stream fileStream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return path;
        }

        public async Task<Stream> DeleteFile(string ruta)
        {
            var filePath = Environment.CurrentDirectory;
            Stream retVal = null;

            if (System.IO.File.Exists(filePath + "'\'" + ruta))
            {
                byte[] fileData = await System.IO.File.ReadAllBytesAsync(filePath);
                retVal = new MemoryStream(fileData);
                System.IO.File.Delete(filePath);
            }
            return retVal;
        }

        public bool IsBase64(string base64String)
        {
            if (string.IsNullOrEmpty(base64String) || base64String.Length % 4 != 0
               || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
                return false;

            try
            {
                Convert.FromBase64String(base64String);
                return true;
            }
            catch (Exception exception)
            {
                // Handle the exception
            }
            return false;
        }
    }
}