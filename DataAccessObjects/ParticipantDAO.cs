using BusinessObjects.DBContext;
using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ParticipantDAO
    {
        GroupStudyContext _context = new GroupStudyContext();
        //----------------------------------------------------
        // Singleton
        public static ParticipantDAO instance = null;
        public static object instanceLock = new object();
        private ParticipantDAO() { }
        public static ParticipantDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ParticipantDAO();
                }
                return instance;
            }
        }
        // Get all Participant
        public List<Participant> GetParticipants() => _context.Participants.ToList();
        // Number student in group by groupID
        public int NumberStudentInGroup(int groupID) => GetParticipants().Where(p => p.GroupId == groupID).Count();

        // Get list Participant by userID
        public List<Participant> GetGroupsJoined(int userID)
        {
            List<Participant> list =  GetParticipants().Where(p => p.UserId == userID).ToList();
            return list;
        }
        // add Participant
        public void AddParticipant(Participant participant)
        {
            var p = _context.Participants.SingleOrDefault(p => p.GroupId == participant.GroupId && p.UserId == participant.UserId);
            if (p != null)
            {
                _context.Participants.Add(participant);
                _context.SaveChanges();
            } else
            {
                throw new Exception("Can not add participant");
            }
            
        }
        // Update Participant
        //public void UpdateParticipant(Participant participant)
        //{
        //    _context.ChangeTracker.Clear();
        //    _context.Participants.Update(participant);
        //    _context.SaveChanges();
        //}
        public void DeleteParticipant(Participant participant)
        {
            var p = _context.Participants.SingleOrDefault(p => p.GroupId == participant.GroupId && p.UserId == participant.UserId);
            if (p != null)
            {
                _context.Participants.Remove(participant);
                _context.SaveChanges();
            } else
            {
                throw new Exception("Can not delete particpant");
            }
        }
    }
}
