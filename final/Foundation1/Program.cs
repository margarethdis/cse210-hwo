
class Program
{
    static void Main(string[] args)
    {
        // Crear videos
        List<Video> videos = new List<Video>();
        videos.Add(new Video("Video 1", "Author 1", 120));
        videos.Add(new Video("Video 2", "Author 2", 180));
        videos.Add(new Video("Video 3", "Author 3", 150));

        // Añadir comentarios a los videos
        videos[0].AddComment(new Comment("User1", "Great video!"));
        videos[0].AddComment(new Comment("User2", "Interesting topic."));
        videos[0].AddComment(new Comment("User3", "I learned a lot."));

        videos[1].AddComment(new Comment("User4", "Nice presentation."));
        videos[1].AddComment(new Comment("User5", "I disagree with some points."));

        videos[2].AddComment(new Comment("User6", "Helpful content."));
        videos[2].AddComment(new Comment("User7", "Thanks for sharing!"));

        // Mostrar detalles de los videos
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}