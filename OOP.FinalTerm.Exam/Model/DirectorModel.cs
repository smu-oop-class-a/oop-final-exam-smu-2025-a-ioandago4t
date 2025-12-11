namespace OOP.FinalTerm.Exam.Model
{
    
    //Inherit PersonModel
    //PersonModel must be created first if not already present
    public class DirectorModel: PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Genres { get; set; }
        public int TotalMoviesCreated { get; set; }
    }
}
