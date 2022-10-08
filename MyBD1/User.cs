using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstBd1
{
    public class User
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime TimeCreate
        {
            get { return DateTime.Now; }
            set { value = value; }
        }
        public User()
        {
            Name = NameGenerator.CreateName();
            Age = AgeGenerator.CreateAge();
        }
        public virtual ICollection<User> Users { get; set; }
    }
}
