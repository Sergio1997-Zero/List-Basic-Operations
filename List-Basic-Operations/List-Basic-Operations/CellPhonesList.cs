using System;
using System.Collections.Generic;
using System.Text;

namespace List_Basic_Operations
{
    public class CellPhonesList
    {
        CellPhonesNode Head;

        public void Add(CellPhones CellPhonesToAdd)
        {
            CellPhonesNode newCellPhonesNode = new CellPhonesNode();
            newCellPhonesNode.CellPhones = CellPhonesToAdd;
            if (Head == null)
            {
                Head = newCellPhonesNode;
            }
            else
            {
                CellPhonesNode Last = Head;
                while (Last.Next != null)
                {
                    Last = Last.Next;
                }
                Last.Next = newCellPhonesNode;
            }
        }
        public void Insert(CellPhones cellphones, int CellPhonesPosition)
        {
            CellPhonesNode newCellPhonesNode = new CellPhonesNode();
            newCellPhonesNode.CellPhones = cellphones;
            newCellPhonesNode.Next = null;
            if (Head == null)
            {
                Head = newCellPhonesNode;
            }
            else
            {
                CellPhonesNode Last;
                Last = Head;

                if (CellPhonesPosition == 1)
                {
                    Head = newCellPhonesNode;
                    newCellPhonesNode.Next = Last;
                }
                else
                {
                    for (int i = 1; i < CellPhonesPosition - 1; i++)
                    {
                        Last = Last.Next;
                        if (Last.Next == null)
                            break;
                    }
                    CellPhonesNode LastNext;
                    LastNext = Last.Next;
                    Last.Next = newCellPhonesNode;
                    newCellPhonesNode.Next = LastNext;
                }
            }
        }
        public void Print()
        {
            CellPhonesNode CELP = Head;
            while (CELP != null)
            {
                Console.WriteLine($"Processor: {CELP.CellPhones.Processor} - Ram: {CELP.CellPhones.Ram} - Storage: {CELP.CellPhones.Storage} - Battery: {CELP.CellPhones.Battery} - Cost: {CELP.CellPhones.Cost} - Color: {CELP.CellPhones.Color} - Units: {CELP.CellPhones.Units} ");
                CELP = CELP.Next;
            }
        }
    }
}
