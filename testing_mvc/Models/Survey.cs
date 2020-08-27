namespace testing_mvc.Models
{
    public class Survey
    {
        public string Name { get; set;}
        public string location{ get; set; }
        public string language{ get; set; }

        public Survey(){

            this.Name = "dan";
            this.location = "the man";
            this.language = "with a plan";

        }
    }
}