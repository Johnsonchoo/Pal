﻿using Pal.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Pal.Service
{
    public interface IFirebaseDatabase
    {
        Task<string> GetUsername(string email);
        void SetUser(string email, string name);
        void UpdateUser(string email, string username);

        void SetMessage(ChatRoom chatRoom,Message message);
        Task<ObservableCollection<Message>> GetMessage(string roomId);
        void SetRead(Message message);
    
        Task<IndividualChatRoom> AddIndividualChatRoom(User user);
        Task<GroupChatRoom> AddGroupChatRoom(GroupChatRoom groupChat);
        Task<IndividualChatRoom> SearchIndividualChatRoom(string userEmail);
        Task<ObservableCollection<object>> GetAllRoom();
        Task<string> SetRoomDestruct(string roomId, bool destructStatus);
        Task<bool> DestructMessage(string MessagesId);

        void AddFriend(User user);
        Task<List<User>> GetFriendsList();
        Task<User> SearchUser(string email);
        Task<object> SearchChatRoomById(string roomId);
        void ClearMessages();
        void ClearAllRooms();


    }
}
