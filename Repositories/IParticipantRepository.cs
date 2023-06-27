using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IParticipantRepository
    {
        List<Participant> GetParticipants();
        int NumberStudentInGroup(int groupID);
        List<Participant> GetGroupsJoined(int userID);
        void AddParticipant(Participant participant);
        void DeleteParticipant(Participant participant);
        List<User> GetListUserInGroup(int groupID);
        List<Group> GetListByUserId(int userId);
    }
}
