<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Stock_Management_System.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row justify-content-center" >
        <span class="border border-primary">
            <div class="card p-3 mb-2 bg-success text-white" style="width: 18rem;">
                <div class="embed-responsive embed-responsive-16by9">
            
                    <img class="card-img-top embed-responsive-item" src="Resources/productcatagory.jpg" alt="Card image cap">
            
                </div>
                <div class="card-body text-center">
                    <h4 class="card-title" >Product Catagory</h4>
                    <p class="card-text">You can add items and set their catagory from here.</p><br/>
                    <a href="CatagorySetupPage.aspx" class="btn btn-primary btn-sm" >Catagory Setup</a>
                </div>
            </div>
        </span>
        <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
        <span class="border border-primary">
            <div class="card p-3 mb-2 bg-success text-white" style="width: 18rem;">
                <div class="embed-responsive embed-responsive-16by9">
            
                    <img class="card-img-top embed-responsive-item" src="Resources/company.jpg" alt="Card image cap">
            
                </div>
                <div class="card-body text-center">
                    <h4 class="card-title" >Product's Company</h4>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="CompanySetUpUi.aspx" class="btn btn-primary btn-sm" >Company Setup</a>
                </div>
            </div>
        </span>
        <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
        <span class="border border-primary">
            <div class="card p-3 mb-2 bg-success text-white" style="width: 18rem;">
                <div class="embed-responsive embed-responsive-16by9">
            
                    <img class="card-img-top embed-responsive-item" src="Resources/company.jpg" alt="Card image cap">
            
                </div>
                <div class="card-body text-center">
                    <h4 class="card-title" >Item Details</h4>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="ItemSetupUi.aspx" class="btn btn-primary btn-sm" >Item Setup</a>
                </div>
            </div>
        </span>
        
    </div>
        <div class="row justify-content-center">
        <span class="border border-primary">
            <div class="card p-3 mb-2 bg-success text-white" style="width: 18rem;">
                <div class="embed-responsive embed-responsive-16by9">
            
                    <img class="card-img-top embed-responsive-item" src="Resources/company.jpg" alt="Card image cap">
            
                </div>
                <div class="card-body text-center">
                    <h4 class="card-title" >Stock In</h4>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="StockInUi.aspx" class="btn btn-primary btn-sm" >Stock In</a>
                </div>
            </div>
        </span>
        <div> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
        <span class="border border-primary">
            <div class="card p-3 mb-2 bg-success text-white" style="width: 18rem;">
                <div class="embed-responsive embed-responsive-16by9">
            
                    <img class="card-img-top embed-responsive-item" src="Resources/company.jpg" alt="Card image cap">
            
                </div>
                <div class="card-body text-center">
                    <h4 class="card-title" >Stock Out</h4>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="StockOutUi.aspx" class="btn btn-primary btn-sm" >Stock Out</a>
                </div>
            </div>
        </span>
        <div> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
        <span class="border border-primary">
            <div class="card p-3 mb-2 bg-success text-white" style="width: 18rem;">
                <div class="embed-responsive embed-responsive-16by9">
            
                    <img class="card-img-top embed-responsive-item" src="Resources/company.jpg" alt="Card image cap">
            
                </div>
                <div class="card-body text-center">
                    <h4 class="card-title" >Search Items</h4>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="SearchVIewItemsSummaryUI.aspx" class="btn btn-primary btn-sm" >AVIS</a>
                </div>
            </div>
        </span>
            <div> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
            <span class="border border-primary">
                <div class="card p-3 mb-2 bg-success text-white" style="width: 18rem;">
                    <div class="embed-responsive embed-responsive-16by9">
            
                        <img class="card-img-top embed-responsive-item" src="Resources/company.jpg" alt="Card image cap">
            
                    </div>
                    <div class="card-body text-center">
                        <h4 class="card-title" >View Sales</h4>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <a href="ViewItemBetweenDatesUI.aspx" class="btn btn-primary btn-sm" >VIBD</a>
                    </div>
                </div>
            </span>
    </div>
    
</asp:Content>
