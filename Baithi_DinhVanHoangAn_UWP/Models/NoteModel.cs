using Baithi_DinhVanHoangAn_UWP.Entity;
using Baithi_DinhVanHoangAn_UWP.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithi_DinhVanHoangAn_UWP.Models
{
    class NoteModel
    {
        public bool Insert(Note note)
        {
            try
            {
                using (var stt = SQLiteUtilc.GetIntances().Connection.Prepare("INSERT INTO Note (Title, Content, CreatedAt, UpdatedAt) VALUES (?, ?, ? , ?)"))
                {
                    stt.Bind(1, note.Title);
                    stt.Bind(2, note.Content);
                    stt.Bind(3, "2010-10-10");
                    stt.Bind(4, "2010-09-09");
                    stt.Step();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public List<Note> Select()
        {
            try
            {
                List<Note> lstNote = new List<Note>();
                using (var stt = SQLiteUtilc.GetIntances().Connection.Prepare("SELECT * from Note"))
                {
                    while(stt.Step() == SQLitePCL.SQLiteResult.ROW)
                    {
                        var getNote = new Note();
                        getNote.Id = Convert.ToInt32(stt[0]);
                        getNote.Title = (string)stt[1];
                        getNote.Content = (string)stt[2];
                        lstNote.Add(getNote);
                    }
                    return lstNote;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
