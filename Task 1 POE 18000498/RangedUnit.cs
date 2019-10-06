﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_POE_18000498
{
    [Serializable]
    class RangedUnit : Unit
    {
         

        public string Name 
        {
            get { return name ; }
            set { name = value; }
        }


        public int PosX
        {
            get { return base.posX; }
            set { base.posX = value; }
        }

        public int PosY
        {
            get { return base.posY; }
            set { base.posY = value; }
        }

        public int Health
        {
            get { return base.health; }
            set { base.health = value; }
        }

        public int MaxHealth
        {
            get { return base.maxHealth; }
        }

        public int Speed
        {
            get { return base.speed; }
        }

        public int Attack
        {
            get { return base.attack; }
        }

        public int AttackRange
        {
            get { return base.attackRange; }
        }

        public string Symbol
        {
            get { return base.symbol; }
        }


        public Faction FactionType
        {
            get { return base.factionType; }
        }

        public bool IsAttacking
        {
            get { return base.isAttacking; }
            set { base.isAttacking = value; }
        }

        private int speedCounter = 1;
        List<Unit> units = new List<Unit>();
        List<buildings> building = new List<buildings>();
        Random r = new Random();
        Unit closestUnit;
        buildings closestBuilding;

        public RangedUnit(string n,int x, int y, Faction faction, int hp, int sp, int att, int attRange, string sym, bool isAtt)
            : base(n, x, y, hp, sp, att, attRange, sym, faction, isAtt)
        {


        }

        public override void Move(int type)
        {
            //Moves towards closest enemey
            if (Health > MaxHealth * 0.25)
            {
                if (type == 0)
                {
                    if (closestUnit is MeleeUnit)
                    {
                        MeleeUnit closestUnitM = (MeleeUnit)closestUnit;

                        if (closestUnitM.PosX > posX && PosX < 20)
                        {
                            posX++;
                        }
                        else if (closestUnitM.PosX < posX && posX > 0)
                        {
                            posX--;
                        }

                        if (closestUnitM.PosY > posY && PosY < 20)
                        {
                            posY++;
                        }
                        else if (closestUnitM.PosY < posY && posY > 0)
                        {
                            posY--;
                        }
                    }
                    else if (closestUnit is RangedUnit)
                    {
                        RangedUnit closestUnitR = (RangedUnit)closestUnit;

                        if (closestUnitR.PosX > posX && PosX < 20)
                        {
                            posX++;
                        }
                        else if (closestUnitR.PosX < posX && posX > 0)
                        {
                            posX--;
                        }

                        if (closestUnitR.PosY > posY && PosY < 20)
                        {
                            posY++;
                        }
                        else if (closestUnitR.PosY < posY && posY > 0)
                        {
                            posY--;
                        }
                    }
                    else if (closestUnit is WizzardUnit)
                    {
                        WizzardUnit closestUnitR = (WizzardUnit)closestUnit;

                        if (closestUnitR.PosX > posX && PosX < 20)
                        {
                            posX++;
                        }
                        else if (closestUnitR.PosX < posX && posX > 0)
                        {
                            posX--;
                        }

                        if (closestUnitR.PosY > posY && PosY < 20)
                        {
                            posY++;
                        }
                        else if (closestUnitR.PosY < posY && posY > 0)
                        {
                            posY--;
                        }
                    }
                }
                else
                {
                    if (closestBuilding is FactoryBuildings)
                    {
                        FactoryBuildings closestBuildingFB = (FactoryBuildings)closestBuilding;

                        if (closestBuildingFB.PosX > posX && PosX < 20)
                        {
                            posX++;
                        }
                        else if (closestBuildingFB.PosX < posX && posX > 0)
                        {
                            posX--;
                        }

                        if (closestBuildingFB.PosY > posY && PosY < 20)
                        {
                            posY++;
                        }
                        else if (closestBuildingFB.PosY < posY && posY > 0)
                        {
                            posY--;
                        }
                    }
                    else if (closestBuilding is ResourceBuilding)
                    {
                        ResourceBuilding closestBuildingRB = (ResourceBuilding)closestBuilding;

                        if (closestBuildingRB.PosX > posX && PosX < 20)
                        {
                            posX++;
                        }
                        else if (closestBuildingRB.PosX < posX && posX > 0)
                        {
                            posX--;
                        }

                        if (closestBuildingRB.PosY > posY && PosY < 20)
                        {
                            posY++;
                        }
                        else if (closestBuildingRB.PosY < posY && posY > 0)
                        {
                            posY--;
                        }
                    }
                }
            }
            else //Moves the unit in a direction that is determined by random
            {
                int direction = r.Next(0, 4);

                if (direction == 0 && PosX < 19)
                {
                    posX++;
                }
                else if (direction == 1 && posX > 0)
                {
                    posX--;
                }
                else if (direction == 2 && posY < 19)
                {
                    posY++;
                }
                else if (direction == 3 && posY > 0)
                {
                    posY--;
                }
            }

        }

        public override void Combat(int type)
        {
            if (type == 0)
            {
                if (closestUnit is MeleeUnit)
                {
                    MeleeUnit M = (MeleeUnit)closestUnit;
                    M.Health -= Attack;
                }
                else if (closestUnit is RangedUnit)
                {
                    RangedUnit R = (RangedUnit)closestUnit;
                    R.Health -= Attack;
                }
                else if (closestUnit is WizzardUnit)
                {
                    WizzardUnit R = (WizzardUnit)closestUnit;
                    R.Health -= Attack;
                }
            }
            else if (type == 1)
            {
                if (closestBuilding is FactoryBuildings)
                {
                    FactoryBuildings FB = (FactoryBuildings)closestBuilding;
                    FB.Health -= Attack;
                }
                else if (closestBuilding is ResourceBuilding)
                {
                    ResourceBuilding RB = (ResourceBuilding)closestBuilding;
                    RB.Health -= Attack;
                }
            }
        }

        public override void CheckAttackRange(List<Unit> uni, List<buildings> build)
        {
            units = uni;
            building = build;

            closestUnit = ClosestEnemy();
            closestBuilding = ClosestBuilding();

            int enemyType;

            int xDis = 0, yDis = 0;

            int uDistance = 10000, bDistance = 10000;
            int distance;

            if (closestUnit is MeleeUnit)
            {
                MeleeUnit M = (MeleeUnit)closestUnit;
                xDis = Math.Abs((PosX - M.PosX) * (PosX - M.PosX));
                yDis = Math.Abs((PosY - M.PosY) * (PosY - M.PosY));

                uDistance = (int)Math.Round(Math.Sqrt(xDis + yDis), 0);
            }
            else if (closestUnit is RangedUnit)
            {
                RangedUnit R = (RangedUnit)closestUnit;
                xDis = Math.Abs((PosX - R.PosX) * (PosX - R.PosX));
                yDis = Math.Abs((PosY - R.PosY) * (PosY - R.PosY));

                uDistance = (int)Math.Round(Math.Sqrt(xDis + yDis), 0);
            }
            else if (closestUnit is WizzardUnit)
            {
                WizzardUnit R = (WizzardUnit)closestUnit;
                xDis = Math.Abs((PosX - R.PosX) * (PosX - R.PosX));
                yDis = Math.Abs((PosY - R.PosY) * (PosY - R.PosY));

                uDistance = (int)Math.Round(Math.Sqrt(xDis + yDis), 0);
            }

            if (closestBuilding is FactoryBuildings)
            {
                FactoryBuildings FB = (FactoryBuildings)closestBuilding;
                xDis = Math.Abs((PosX - FB.PosX) * (PosX - FB.PosX));
                yDis = Math.Abs((PosY - FB.PosY) * (PosY - FB.PosY));

                bDistance = (int)Math.Round(Math.Sqrt(xDis + yDis), 0);
            }
            else if (closestBuilding is ResourceBuilding)
            {
                ResourceBuilding RB = (ResourceBuilding)closestBuilding;
                xDis = Math.Abs((PosX - RB.PosX) * (PosX - RB.PosX));
                yDis = Math.Abs((PosY - RB.PosY) * (PosY - RB.PosY));

                bDistance = (int)Math.Round(Math.Sqrt(xDis + yDis), 0);
            }

            if (units[0] != null)
            {
                if (uDistance < bDistance)
                {
                    distance = uDistance;
                    enemyType = 0;
                }
                else
                {
                    distance = bDistance;
                    enemyType = 1;
                }
            }
            else
            {
                distance = bDistance;
                enemyType = 1;
            }

            //Checks to see if they are below 25% health so they move rather than attacking
            if (Health > MaxHealth * 0.25)
            {
                if (distance <= AttackRange)
                {
                    IsAttacking = true;
                    Combat(enemyType);
                }
                else
                {
                    IsAttacking = false;
                    Move(enemyType);
                }
            }
            else
            {
                Move(enemyType);
            }

        }

        public override Unit ClosestEnemy()
        {

            int xDis, yDis;
            double distance;
            double temp = 0;
            Unit target = null;

            foreach(Unit u in units)
            {
                if (FactionType != u.factionType)
                {
                    xDis = Math.Abs((PosX - u.posX) * (PosX - u.posX));
                    yDis = Math.Abs((PosY - u.posY) * (PosY - u.posY));

                    distance = Math.Round(Math.Sqrt(xDis + yDis), 0);

                    if (distance > temp)
                    {
                        temp = distance;

                        temp = distance;
                        target = u;
                    }
                }

            }
            return target;
            
        }

        public buildings ClosestBuilding()
        {
            int xDis = 0, yDis = 0;
            double distance = 1000;
            double temp = 1000;
            buildings target = null;

            foreach (buildings u in building)
            {
                if (u is FactoryBuildings)
                {
                    FactoryBuildings b = (FactoryBuildings)u;
                    if (factionType != b.Faction)
                    {
                        xDis = Math.Abs((PosX - b.PosX) * (PosX - b.PosX));
                        yDis = Math.Abs((PosY - b.PosY) * (PosY - b.PosY));

                        distance = Math.Round(Math.Sqrt(xDis + yDis), 0);
                    }
                }
                else if (u is ResourceBuilding)
                {
                    ResourceBuilding b = (ResourceBuilding)u;
                    if (factionType != b.Faction)
                    {
                        xDis = Math.Abs((PosX - b.PosX) * (PosX - b.PosX));
                        yDis = Math.Abs((PosY - b.PosY) * (PosY - b.PosY));

                        distance = Math.Round(Math.Sqrt(xDis + yDis), 0);
                    }
                }
                if(distance < temp)
                {
                    temp = distance;
                    target = u;
                }

            }
            return target;
        }

        public override bool Death()
        {

            if(Health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override string ToString()
        {
            return "Snipers X" + PosX
                + " Y: " + PosY
                + "\nMax Health: " + MaxHealth
                + "\nHealth: " + Health
                + "\nSpeed: " + Speed
                + "\nAttack Damage: " + Attack
                + "\nAttack Range: " + AttackRange
                + "\nFaction: " + FactionType;
        }

    }
}
