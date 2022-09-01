// See https://aka.ms/new-console-template for more information



using Azure.Storage.Blobs;

string bolbUrl = "https://blobfileuploadlpk.blob.core.windows.net/rootcontainer?sp=racwdli&st=2022-09-01T03:12:43Z&se=2022-09-08T11:12:43Z&sv=2021-06-08&sr=c&sig=ewDASVDH8wIBu9cUiXMycUDRJVfs6hWdELFhRZdf4Gw%3D";
string connetionStrong = "DefaultEndpointsProtocol=https;AccountName=blobfileuploadlpk;AccountKey=Jy4C5UaEZOGrrrgfrAogwa7zg7EorsMad6G4cgvLG/7P5ZJemqAcjLHAFzgnHM+bOLdPpT11oZMp+AStD/RKcA==";
string container = "rootcontainer";
string folderPath = @"D:\MyProjects\Azure\AzureConsoleApp\Images";

var files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);

BlobContainerClient blobContainerClient = new BlobContainerClient(connetionStrong, container);
foreach (var file in files)
{
    var filePathetoUpaload = file.Replace(folderPath,String.Empty);
    using(MemoryStream ms = new MemoryStream(File.ReadAllBytes(file)))
    {
        blobContainerClient.UploadBlob(filePathetoUpaload,ms);
    }

}

Console.WriteLine("Uplaod Ccomplete");

 