using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using DataLayerLibrary.DataAccess;
using DataLayerLibrary.DataModels;

namespace DataLayerLibrary.DataLogic
{
    public class SubscriptionProcessor
    {
        public static void CreateSubscription(string subscriptionName, string type, int user_Id)
        {
            SubscriptionDataModel data = new SubscriptionDataModel
            {
                SubscriptionName = subscriptionName,
                Type = type,
                User_Id = user_Id
            };
            string sql =
                @"INSERT INTO subscriptions (User_Id, SubscriptionName, Type) VALUES (@User_Id, @SubscriptionName, @Type);";
            SQLAccessData.SaveData(sql, data);
        }

        public static List<SubscriptionDataModel> GetSubscriptionsViaUserId(int user_Id)
        {
            string sql = $"SELECT * FROM subscriptions WHERE User_Id = '{user_Id}';";
            return SQLAccessData.LoadData<SubscriptionDataModel>(sql);
        }

        public static void RemoveSubscription(int user_Id, string subscriptionName)
        {
            string sql =
                $"DELETE FROM subscriptions WHERE User_Id = '{user_Id}' AND SubscriptionName = '{subscriptionName}';";
            SQLAccessData.DeleteData(sql);
        }

        public static int GetAmountOfSubscriptionsByName(string subscriptionName)
        {
            string sql =
                $"SELECT count(SubscriptionName) FROM subscriptions WHERE SubscriptionName = '{subscriptionName}' group by SubscriptionName;";

            return SQLAccessData.LoadFirstEntry<int>(sql);
        }

        public static bool GetSubscriptionStatus(int user_Id, string subscriptionName)
        {
            string sql =
                $"SELECT * FROM subscriptions WHERE User_Id = '{user_Id}' AND SubscriptionName = '{subscriptionName}';";
            try
            {
                SubscriptionDataModel obj = SQLAccessData.LoadFirstEntry<SubscriptionDataModel>(sql);
                if (obj == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return true;
            }
        }

        public static List<SubscriptionDataModel> GetFiveMostRecurringGenres()
        {
            string sql =
                $"SELECT * , COUNT(SubscriptionName) AS `value_occurrence` FROM subscriptions GROUP BY SubscriptionName HAVING type= 'Genre' ORDER BY `value_occurrence` DESC LIMIT 5";
            return SQLAccessData.LoadData<SubscriptionDataModel>(sql);
        }

        public static List<SubscriptionDataModel> GetFiveMostRecurringTags()
        {
            string sql =
                $"SELECT * , COUNT(SubscriptionName) AS `value_occurrence` FROM subscriptions GROUP BY SubscriptionName HAVING type= 'Tag' ORDER BY `value_occurrence` DESC LIMIT 5";
            return SQLAccessData.LoadData<SubscriptionDataModel>(sql);
        }
    }
}