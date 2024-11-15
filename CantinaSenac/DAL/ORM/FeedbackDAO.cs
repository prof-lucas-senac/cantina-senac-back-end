public class FeedbackDAO {
    public void Adicionar(Feedback feedback) {
        try {
            CantinaSenacContext context = new CantinaSenacContext();
            context.Feedback.Add(feedback);
            context.SaveChanges();
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            throw;
        }
    }

    public List<Feedback> ListarTodos() {
        try {
            CantinaSenacContext context = new CantinaSenacContext();
            List<Feedback> feedbacks = context.Feedback.ToList();

            return feedbacks;
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            return null;
        }
    }
}