namespace AdiSchedule
{
    public class Appointment
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
    }
}
