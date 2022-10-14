using CommonLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortFolio_Management.Models;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperationInEntityFramework.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
    public class PortFolioManagementController : ControllerBase
    {
        private readonly IPortFolioManagementSL _portFolioSL;
        public PortFolioManagementController(IPortFolioManagementSL portFolioSL)
        {
            _portFolioSL = portFolioSL;
        }

        [HttpPost]
        public async Task<IActionResult> AddStocks(AddStocksRequest request)
        {
            AddStocksResponse response = new AddStocksResponse();
            try
            {
                response = await _portFolioSL.AddStocks(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            return Ok(response);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllStocks([FromQuery]GetAllStocksRequest request)
        {
            GetStocksResponse response = new GetStocksResponse();
            try
            {
                response = await _portFolioSL.GetAllStocks(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            return Ok(response);
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateStocks(UpdateStoke request)
        {
            UpdateStokeResponse response = new UpdateStokeResponse();
            try
            {
                response = await _portFolioSL.UpdateStocks(request);

            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteStocks([FromQuery]int StokeID)
        {
            DeleteStokeResponse response = new DeleteStokeResponse();
            try
            {
                response = await _portFolioSL.DeleteStocks(StokeID);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = "Exception Message : " + ex.Message;
            }
            return Ok(response);
        }

    }
}
