public class FeedbackDAO
{
    public void Adicionar(Feedback feedback) {
        try
        {
            CantinaSenacContext context = new CantinaSenacContext();
            context.Feedback.Add(feedback);
            context.SaveChanges();
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    public List<Feedback> ListarTodos(){
        try
        {
            CantinaSenacContext context = new CantinaSenacContext();
            List<Feedback> feedbacks = context.Feedback.ToList();
            return feedbacks;
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.Message);
            return null;
        }
    }
}