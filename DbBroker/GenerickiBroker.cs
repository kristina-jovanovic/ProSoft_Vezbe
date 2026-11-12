using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Domain;
using Microsoft.Data.SqlClient;

namespace DbBroker
{
    public class GenerickiBroker
    {
        DbKonekcija konekcija;
        public GenerickiBroker()
        {
            konekcija = new DbKonekcija();
        }

        public void OtvoriKonekciju()
        {
            konekcija.OtvoriKonekciju();
        }

        public void ZatvoriKonekciju()
        {
            konekcija.ZatvoriKonekciju();
        }

        public void ZapocniTransakciju()
        {
            konekcija.ZapocniTransakciju();
        }

        public void Rollback()
        {
            konekcija.Rollback();
        }

        public void Commit()
        {
            konekcija.Commit();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand command = konekcija.KreirajKomandu();
            command.CommandText = $"select * from {entity.TableName} {entity.Join}";
            using SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose(); //ili korisiti using koji sam vodi racuna o oslobadjanju resursa
            return list;
        }

        public IEntity Add(IEntity entity)
        {
            using (SqlCommand command = konekcija.KreirajKomandu())
            {
                command.CommandText = $"insert into {entity.TableName} values ({entity.Values})";
                command.ExecuteNonQuery();
                return entity;
            }
        }

        //Edit (Update)
        //Delete
    }
}
