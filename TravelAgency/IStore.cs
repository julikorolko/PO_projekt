﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgency
{
	interface IStore
	{
		void AddOffer(Offer offer);
		void RemoveOffer(Offer offer);
		void ClearOffers();
	}
}
