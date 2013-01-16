using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUSGives.Entities
{
    public class Electronics
    {
        public HashSet<ElectronicPurchase> ElectronicPurchases { get; set; }
        
        public bool PurchaseTelevision
        {
            get { return ElectronicPurchases.Contains(ElectronicPurchase.Television); }
        }
        
        public bool PurchaseHomeTheatre
        {
            get { return ElectronicPurchases.Contains(ElectronicPurchase.HomeTheatre); }
        }
        
        public bool PurchaseMusicSystem
        {
            get { return ElectronicPurchases.Contains(ElectronicPurchase.MusicSystem); }
        }
        
        public bool PurchaseComputer
        {
            get { return ElectronicPurchases.Contains(ElectronicPurchase.Computer); }
        }
        
        public bool PurchaseDishwasher
        {
            get { return ElectronicPurchases.Contains(ElectronicPurchase.Dishwasher); }
        }
        
        public bool PurchaseFridge
        {
            get { return ElectronicPurchases.Contains(ElectronicPurchase.Fridge); }
        }
        
        public bool PurchaseWashingMachine
        {
            get { return ElectronicPurchases.Contains(ElectronicPurchase.WashingMachine); }
        }
        
        public bool PurchaseVacuumCleaner
        {
            get { return ElectronicPurchases.Contains(ElectronicPurchase.VacuumCleaner); }
        }

        public Electronics()
        {
            ElectronicPurchases = new HashSet<ElectronicPurchase>();
        }
    }
}
