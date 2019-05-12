using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Models.DTO;
using Pokebook.core.Repositories.Specific;

namespace Pokebook.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendShipsController : ControllerCrudBase<Friendship>
    {
        public FriendShipsController(PokebookContext dbc, IMapper m, FriendshipRepository repo) : base(dbc, m, repo)
        {
        }

        [HttpGet]
        [Route("Get/{userid}")]
        public IActionResult GetFriendshipsForUser(Guid userid)
        {
            List<Friendship> friendshipsForUser = unitOfWork.Friendships.GetByUserId(userid);
            List<FriendWithFriendshipDTO> friendshipDTOs = new List<FriendWithFriendshipDTO>();
            foreach(var friendship in friendshipsForUser)
            {
                Guid friendId = new Guid();
                if (friendship.IdApprover == userid) friendId = friendship.IdRequester;
                else friendId = friendship.IdApprover;
                User friend = unitOfWork.Users.FindUserById(friendId);
                friendshipDTOs.Add(new FriendWithFriendshipDTO() { Friend = friend, Friendship = friendship });
            }
            return Ok(friendshipDTOs);
        }

        [HttpGet]
        [Route("GetFriendship/{userid}/{friendid}")]
        public IActionResult GetFriendship(Guid userid, Guid friendid)
        {
            return Ok(unitOfWork.Friendships.GetFriendship(userid, friendid));
        }

        [HttpGet]
        [Route("GetFriendsToApprove/{userid}")]
        public IActionResult GetFriendsToApprove(Guid userid)
        {
            List<FriendWithFriendshipDTO> friendWithFriendshipDTOList = new List<FriendWithFriendshipDTO>();
            List<FriendshipDTO> friendIdWithfriendshipDTOs = unitOfWork.Friendships.GetFriendIdWithFriendshipDTOs(userid);
            foreach(var dto in friendIdWithfriendshipDTOs)
            {
                User friend = unitOfWork.Users.FindUserById(dto.FriendId);
                FriendWithFriendshipDTO friendWithFriendshipDTO = new FriendWithFriendshipDTO()
                {
                    Friend = friend,
                    Friendship = dto.Friendship
                };
                friendWithFriendshipDTOList.Add(friendWithFriendshipDTO);
            }

            var selection = friendWithFriendshipDTOList.Where(f => f.Friendship.Accepted == false && f.Friendship.IdApprover == userid)
                                .Select(f => f.Friend).ToList();
            return Ok(selection);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Friendship friendship)
        {
            return Ok(Post(friendship));
        }

        [HttpPut]
        [Route("Approve/{requesterId}/{approverId}")]
        public IActionResult ApproveFriendRequest(Guid requesterId, Guid approverId)
        {
            Friendship friendship = unitOfWork.Friendships.GetFriendship(requesterId, approverId);
            friendship.Accepted = true;
            return Ok(Put(friendship.Id, friendship));
        }
    }
}