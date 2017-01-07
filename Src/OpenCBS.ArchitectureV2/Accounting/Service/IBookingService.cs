﻿using System;
using System.Collections.Generic;
using System.Data;
using OpenCBS.Extension.Accounting.Interface.Repository;
using OpenCBS.Extension.Accounting.Model;
using OpenCBS.Extension.Accounting.Repository;

namespace OpenCBS.Extension.Accounting.Service
{
    public interface IBookingService
    {
        void SaveBookings(IEnumerable<Booking> entity, IDbTransaction tx = null);
        void SaveBooking(Booking booking, IDbTransaction tx = null);
        void UpdateBookings(IEnumerable<Booking> entity, IDbTransaction tx = null);
        void DeleteBooking(int bookingId, IDbTransaction tx = null);
        void DeleteBookingsByEvent(IDictionary<string, object> entity, IDbTransaction tx = null);
        Booking Get(int bookingId);
        IEnumerable<BookingDto> SelectBookings(DateTime from, DateTime to, Account debit, Account credit);
        IEnumerable<Account> SelectAllAccounts();
        IBookingRepository Repository { set; }
        void CloseAccount(DateTime date, Account account, IDbTransaction tx = null);
        void RecoverAccount(Account account, IDbTransaction tx = null);
        decimal GetAccountBalance(DateTime date, Account number);
    }
}
