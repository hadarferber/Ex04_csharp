using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {

        public string Title { get; }
        public IMenuAction Action { get; }
        public List<MenuItem> SubItems { get; }

        public MenuItem(string title, IMenuAction action = null)
        {
            Title = title;
            Action = action;
            SubItems = new List<MenuItem>();
        }


        public bool IsLeaf
        {
            get { return Action != null; }
        }


        public void AddSubItem(MenuItem item)
        {
            SubItems.Add(item);
        }

        public void Activate()
        {
            if (Action != null)
            {
                Action.ExecuteAction();
            }
        }
    }
}
