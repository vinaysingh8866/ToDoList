using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }

        public string UserEmail { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime DueDate { get; set; }

        public bool Done { get; set; }

        public DateTime DoneDate { get; set; }

        public ToDo()
        {

        }


    }
}
