using BusinessObjects.DBContext;
using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class GroupDAO
    {
        private static GroupStudyContext _context = new GroupStudyContext();

        //GetGroups
        public static IEnumerable<Group> GetGroups() => _context.Groups.ToList();

        //Find
        private static Group Find(int id) => _context.Groups.FirstOrDefault(_ => _.GroupId == id);

        //AddNew
        public static void Add(Group currentGroup)
        {
            if(currentGroup == null)
            {
                throw new ArgumentNullException(nameof(currentGroup));
            }

            if(Find(currentGroup.GroupId) == null)
            {
                _context.Groups.Add(currentGroup);
                _context.SaveChanges();
            }
        }
        
        //Update
        public static void Update(Group currentGroup)
        {
            if(currentGroup == null)
            {
                throw new ArgumentNullException(nameof(currentGroup));
            }

            try
            {
                if(Find(currentGroup.GroupId) != null)
                {
                    _context.ChangeTracker.Clear();
                    _context.Groups.Update(currentGroup);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Group does not exist!");
            }
        }

        //Delete
        public static void Delete(int Id)
        {
            try
            {
                Group group = Find(Id);
                if(group != null)
                {
                    _context.Groups.Remove(group);
                    _context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Group does not exist!");
            }
        }

        public static IEnumerable<Group> SortById()
        {
            return _context.Groups.OrderBy(_=> _.GroupId);
        }
    }
}
