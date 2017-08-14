using CarProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarProj.Models
{
    public class Car
    {
        public Car()
        {
            _imgsrc = null;
            _description = null;
            _makemodel = null;
            _mileage = 0;

        }
        private string _imgsrc;

        private string _description;

        private string _makemodel;
        private uint _mileage;


        public string Pictures
        {
            get
            {
                return _imgsrc;
            }

            set
            {
                _imgsrc = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string Makemodel
        {
            get
            {
                return _makemodel;
            }

            set
            {
                _makemodel = value;
            }
        }

        public uint Mileage
        {
            get
            {
                return _mileage;
            }

            set
            {
                _mileage = value;
            }
        }



    }
}

public class Inventory
{
     public Inventory()
    {
        warehouse = new List<Car>();
        
    }
    private List<Car> warehouse;
    

    public List<Car> Warehouse
    {
        get
        {
            return warehouse;
        }

        set
        {
            warehouse = value;
        }
    }

    public int Size
    {
        get
        {
            return warehouse.Count;
        }
    }
}