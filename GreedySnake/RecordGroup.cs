using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GreedySnake
{
    public class RecordGroup
    {
        const int RECORD_AMOUNT = 3;

        public string mapName;

        public SortedSet<GameRecord> records;

        public void AddRecord(GameRecord record)
        {
            if (records.Count() >= RECORD_AMOUNT)
            {
                records.Remove(records.First());
            }

            records.Add(record);
        }

        public bool IsBetterRecord(GameRecord record)
        {
            if (records.Count() < RECORD_AMOUNT)
            {
                return true;
            }
            else
            {
                GameRecord worstRecord = records.First();
                
                return record.CompareTo(worstRecord) > 0;
            }
        }

        protected List<GameRecord> ReadRecordsFromFile(String fileName)
        {
            List<GameRecord> mapRecords = new List<GameRecord>();

            FileStream file = new FileStream(fileName + ".txt", FileMode.OpenOrCreate);
            StreamReader fileReader = new StreamReader(file);
            try
            {
                string line;
                while ((line = fileReader.ReadLine()) != null && line.Count() != 0)
                {
                    mapRecords.Add(DeserializeGameRecord(line));
                }
            }
            catch (FileNotFoundException e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                if (fileReader != null)
                {
                    fileReader.Close();
                }
                if (file != null)
                {
                    file.Close();
                }
            }

            return mapRecords;
        }

        GameRecord DeserializeGameRecord(string recordLine)
        {
            if (recordLine == null || recordLine.Count() == 0)
            {
                throw new ArgumentException("Damaged Game Record File!");
            }
            string[] fields = recordLine.Split(new Char[] { '|' });

            return new GameRecord(fields[0], Int32.Parse(fields[1]), Convert.ToDateTime(fields[2]));
        }

        public bool WriteRecordsToFile(string fileName)
        {
            string[] serializedRecord = new string[RECORD_AMOUNT];

            try
            {
                int index = 0;
                while (records.Count() != 0)
                {
                    GameRecord r = records.First();
                    serializedRecord[index++] = SerializeGameRecord(r);
                    records.Remove(r);
                }

                File.WriteAllLines(fileName + ".txt", serializedRecord);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            
            return true;
        }

        public string SerializeGameRecord(GameRecord record)
        {
            return record.Name + "|" + record.SnakeLength + "|" + record.Date;
        }
    }
}
