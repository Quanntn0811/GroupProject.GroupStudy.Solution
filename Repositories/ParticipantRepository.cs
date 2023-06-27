using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
        void IParticipantRepository.AddParticipant(Participant participant) => ParticipantDAO.Instance.AddParticipant(participant);

        void IParticipantRepository.DeleteParticipant(Participant participant) => ParticipantDAO.Instance.DeleteParticipant(participant);

        List<Participant> IParticipantRepository.GetGroupsJoined(int userID) => ParticipantDAO.Instance.GetGroupsJoined(userID);

        List<Participant> IParticipantRepository.GetParticipants() => ParticipantDAO.Instance.GetParticipants();

        int IParticipantRepository.NumberStudentInGroup(int groupID) => ParticipantDAO.Instance.NumberStudentInGroup(groupID);

        List<User> IParticipantRepository.GetListUserInGroup(int groupID) => ParticipantDAO.Instance.GetListUserInGroup(groupID);

        public List<Group> GetListByUserId(int userId) => ParticipantDAO.Instance.GetListByUserId(userId);
    }
}
