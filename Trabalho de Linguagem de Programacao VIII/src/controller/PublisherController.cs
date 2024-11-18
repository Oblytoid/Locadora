using Locadora.src.model;
using Locadora.src.services;
using System.Collections.Generic;

namespace Locadora.src.controller
{
    public class PublisherController
    {
        static private PublisherRepository publisherRepository = new PublisherRepository();

        public static bool RegisterPublisher(PublisherItem publisher)
        {
            if (string.IsNullOrWhiteSpace(publisher.Name))
            {
                return false;
            }

            publisherRepository.SavePublisher(publisher);
            return true;
        }

        public static PublisherItem GetPublisher(int id)
        {
            return publisherRepository.GetPublisherById(id);
        }

       
        public static List<PublisherItem> GetAllPublishers()
        {
            return publisherRepository.GetAllPublishers();
        }

        public static bool UpdatePublisher(PublisherItem publisher)
        {
            if (string.IsNullOrWhiteSpace(publisher.Name))
            {
                return false;
            }

            publisherRepository.UpdatePublisher(publisher);
            return true;
        }

   
        public static bool DeletePublisher(int id)
        {
            publisherRepository.DeletePublisher(id);
            return true;
        }
    }
}
