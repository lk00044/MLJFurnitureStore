﻿/// <summary>
/// Handles the interaction between the view and the Member Data Access Layer     
/// </summary>
/// 
using Members.Model;
using Members.DAL;
using UpdateMembers.DAL;

namespace Members.Controller
{
    public class EditRegistrationController
    {
        private readonly UpdateMembersDAL _updateMemberDAL;

        public EditRegistrationController()
        {
            _updateMemberDAL = new UpdateMembersDAL();
        }

        /// <summary>
        /// search a store member by ID
        /// </summary>
        public List<Member> GetMemberByID(int ID)
        {
            return this._updateMemberDAL.GetMemberByID(ID);
        }

        /// <summary>
        /// Update/edit a store member
        /// </summary>
        public void UpdateMember(Member storeMember)
        {
            this._updateMemberDAL.UpdateMember(storeMember);
        }

    }
}
