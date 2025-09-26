using System.Collections.Generic;
public class Video
{
    public string _titleVideo;
    public string _authorVideo;
    public double _lengthVideo;
    public List<Comment> _comments = new List<Comment>();


    public int GetNumberComments()
    {
        int count = 0;
        foreach (Comment comment in _comments)
        {
            count = count + 1;
        }
        return count;
    }
}