using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public interface IGradeTracker
    {
        void AddGrade(float grade);
        GradeStatistics ComputeStatistics();
        void WriteGrades(TextWriter textWriter);
        string Name { get; set; }
        event NameChangedDelegate NameChanged;


    }
    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter textWriter);

        private string _name;// field is set to private so name can only be set via the property Name
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be Null or empty");

                }
                if (Name != value)
                {
                    var oldValue = _name;
                    _name = value;
                    if (NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs
                        {
                            OldValue = oldValue,
                            NewValue = value
                        };
                        NameChanged(this, args);
                    }
                }
            }
        }
        public event NameChangedDelegate NameChanged; // by adding the keyword event this delegate is promoted to an event
    }
}
