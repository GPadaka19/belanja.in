using COBA_COBA_UTS.Model.Context;
using COBA_COBA_UTS.Model.Entity;
using COBA_COBA_UTS.Model.Repository;
using COBA_COBA_UTS.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace COBA_COBA_UTS.Controller
{
    public class BelanjaController
    {
        private BelanjaRepository _repository;

        public BelanjaController(DbContext context)
        {
            _repository = new BelanjaRepository(context);
        }
        public List<History> GetHistory()
        {
            return _repository.GetHistory();
        }

        public List<Produk> GetAllProducts()
        {
            List<Produk> products = _repository.GetAllProducts();
            return products;
        }
        public List<Cart> GetAllProductsInCart()
        {
            return _repository.GetAllProductsInCart();
        }
        public List<Payment> GetAllProductsInPayment()
        {
            return _repository.GetAllProductsInPayment();
        }
        public Image GetImageFromBlob(byte[] blob)
        {
            return _repository.GetImageFromBlob(blob);
        }

        public List<Produk> ReadByNama(string keyword)
        {
            List<Produk> list = new List<Produk>();

            using (DbContext context = new DbContext())
            {
                _repository = new BelanjaRepository(context);

                list = _repository.ReadByNama(keyword);
            }

            return list;
        }

        public Produk GetProductById(string keyword)
        {
            return _repository.ReadById(keyword);
        }

        public int AddToCart(Produk product)
        {

            return _repository.AddToCart(product);
        }
        public int AddToHistory(Payment payment)
        {
            return _repository.AddToHistory(payment);
        }
        public bool UpdateCart(Cart cart)
        {
            return _repository.UpdateCart(cart);
        }

        public bool UpdateStock(Cart cart)
        {
            return _repository.UpdateStock(cart);
        }
        public int AddToPayment(Cart cart)
        {
            return _repository.AddToPayment(cart);
        }
        public bool DeleteProductFromCart(string id_produk)
        {
            return _repository.DeleteProductFromCart(id_produk);
        }
        public decimal GetPriceByProductId(string productId)
        {
            decimal price = _repository.GetPriceByProductId(productId);
            return price;
        }
        public bool DeleteProductFromPayment(string id_produk)
        {
            return _repository.DeleteProductFromPayment(id_produk);
        }
        public DataTable GetPromo()
        {
           return _repository.GetPromo(); 
        }
        public float GetPromoValue(string promoCode)
        {
            return _repository.GetPromoValue(promoCode);
        }
        public DataTable GetEkspedisi()
        {
            return _repository.GetEkspedisi();
        }
        public float GetEkspedisiValue(string Ekspedision)
        {
            return _repository.GetEkspedisiValue(Ekspedision);
        }

    }
}
