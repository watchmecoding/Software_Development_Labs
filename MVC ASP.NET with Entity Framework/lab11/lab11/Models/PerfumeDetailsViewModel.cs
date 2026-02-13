namespace lab11.Models
{
    public class PerfumeDetailsViewModel
    {
        public string PerfumeName { get; set; }
        public string Volume { get; set; }
    }

    public class PerfumeWithTypeViewModel
    {
        public int PerfumeID { get; set; }
        public string PerfumeName { get; set; }
        public string VolumeName { get; set; }
    }

    public class PerfumeEditViewModel
    {
        public int PerfumeID { get; set; }
        public string PerfumeName { get; set; }
        public int TypeID { get; set; }
        public string VolumeName { get; set; }
    }
}
