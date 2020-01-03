﻿using CommercialApplicationCommand.DomainLayer.Entities.ActionEntities;
using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommercialApplication.DomainLayer.Repositories.Commands.ActionCommands
{
    public class DeleteActionCommand : IActionCommand
    {
        public void Execute(NpgsqlConnection connection, Action actionEntity, IDbTransaction transaction = null)
        {
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand("delete_action", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("criteriaid", actionEntity.Id);

            // Execute the procedure and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();
            connection.Close();
        }
    }
}
