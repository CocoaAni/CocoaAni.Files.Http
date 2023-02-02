namespace CocoaAni.Files.Http;

public class HttpFile
{
    public string NetUrl { get; }
    public string LocalPath { get; }

    public FileInfo Info { get; }

    public HttpFile(string localPath, string netUrl)
    {
        LocalPath = localPath;
        NetUrl = netUrl;
        Info = new FileInfo(localPath);
    }

    public HttpFile(FileInfo fileInfo, string netUrl) : this(fileInfo.FullName, netUrl)
    {
        Info = fileInfo;
    }
}