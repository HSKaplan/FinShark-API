using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Content = commentModel.Content,
                Title = commentModel.Title,
                CreatedOn = commentModel.CreatedOn,
                CreatedBy = commentModel.appUser.UserName,
                StockId = commentModel.StockId

            };

        }


        public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int stockId)
        {
            return new Comment
            {

                Content = commentDto.Content,
                Title = commentDto.Title,
                StockId = stockId

            };

        }
        
        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        {
            return new Comment
            {

                Content = commentDto.Content,
                Title = commentDto.Title,
            
            };

        }

        
    }
}