using System.Dynamic;

namespace Quest
{
    public class Hat
    {
        // Mutable properties
        public int ShininessLevel { get; set; }
        
        // Computed property
        public string ShininessDescription
        {
            get
            {
                if (ShininessLevel < 2)
                {
                    return "dull";
                }
                else if (ShininessLevel <= 5)
                {
                    return "noticeable";
                }
                else if (ShininessLevel <= 9)
                {
                    return "bright";
                }
                else
                {
                    return "blinding";
                }
            }
        }
    }
}
