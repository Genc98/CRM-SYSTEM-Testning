namespace E2ETesting.Steps;

using Microsoft.Playwright;
using TechTalk.SpecFlow;
using Xunit;


[Binding]
public class CRMsteps
{
    
    
    private IPlaywright _playwright;
    private IBrowser _browser;
    private IBrowserContext _context;
    private IPage _page;

    [BeforeScenario]
    public async Task Setup()
    {
        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync(new() { Headless = false, SlowMo = 500 });
        _context = await _browser.NewContextAsync();
        _page = await _context.NewPageAsync();
    }

    [AfterScenario]
    public async Task Teardown()
    {
        await _browser.CloseAsync();
        _playwright.Dispose();
    }
    
    // STEPS:
    
    
    //TEST SEND FORM AS A CUSTOMER 
    
    [Given(@"I am on the CRM system startpage")]
    public async Task GivenIAmOnTheCrmSystemStartpage()
    {
        await _page.GotoAsync("http://localhost:3000/");
        // await _page.WaitForTimeoutAsync(3000);
    }
    
    [When(@"I enter ""(.*)"" as the email")]
    public async Task WhenIEnterAsTheEmail(string email)
    {
        await _page.FillAsync("input[name='email']", email);
    }

    [When(@"I enter ""(.*)"" as the service_product")]
    public async Task WhenIEnterAsTheServiceProduct(string service_product)
    {
        await _page.FillAsync("input[name='service_product']", service_product);
    }

    [When(@"I enter ""(.*)"" as the message")]
    public async Task WhenIEnterAsTheMessage(string message)
    {
        await _page.FillAsync("textarea[name='message']", message);
    }

    [When(@"I send the form")]
    public async Task WhenISendTheForm()
    {

        await Task.WhenAll(
            _page.WaitForURLAsync("http://localhost:3000/confirmation"),
            _page.ClickAsync(".sendBtn")
        );
    }

    [Then(@"I will get a confirmation that a confirmation email has been send")]
    public async Task ThenIWillGetAConfirmationThatAConfirmationEmailHasBeenSend()
    {
        var heading = await _page.InnerTextAsync("h4");
        Assert.Equal("We have received your message and will get back to you as soon as possible. Best regards,", heading);
    }
    
    
    
    //TEST LOGIN AGENT/ADMIN

    [When(@"I click on login and will get to login page")]
    public async Task WhenIClickOnLoginAndWillGetToLoginPage()
    {
        await Task.WhenAll(
            _page.WaitForURLAsync("http://localhost:3000/login"),
            _page.ClickAsync(".logInBtn")
        );
    }
    
    [When(@"I enter ""(.*)"" as email")]
    public async Task WhenIEnterAsEmailAsAgent(string email)
    {
         await _page.FillAsync("input[placeholder='Email']", email);
    }

    [When(@"I enter ""(.*)"" as password")]
    public async Task WhenIEnterAsPasswordAsAgent(string password)
    {
        await _page.FillAsync("input[placeholder='Password']", password);
    }

    [When(@"I select ""(.*)"" as role")]
    public async Task WhenISelectAsAgent(string role)
    {
        await _page.ClickAsync("input[placeholder='Role']");
        await _page.ClickAsync($"text={role}");
    }
    
    //IF YOU LOG IN AS AGENT YOU WILL BE REDIRECTED TO the DASHBOARD
    [When(@"I click login as agent")]
    public async Task ThenIClickLogin()
    {
        await Task.WhenAll(
            _page.WaitForURLAsync("http://localhost:3000/dashboard"),
            _page.ClickAsync(".sendBtn")
        );
    }
    
    [Then(@"I am on the dashboard")]
    public async Task ThenIAmOnTheDashboard()
    {
        
        var heading = await _page.InnerTextAsync("h1");
        Assert.Equal("Welcome to our CRM-System ", heading);
        

    }
    
    //IF YOU LOG IN AS ADMIN YOU WILL BE REDIRECTED TO ADMINPAGE
    [When(@"I click login as admin")]
    public async Task WhenIClickLoginAsAdmin()
    {
        await Task.WhenAll(
            _page.WaitForURLAsync("http://localhost:3000/adminPage"),
            _page.ClickAsync(".sendBtn")
        );
    }

    [Then(@"I am on the dashboard for admins")]
    public async Task ThenIAmOnTheDashboardForAdmins()
    {
        var heading = await _page.InnerTextAsync("h1");
        Assert.Equal("Welcome to our CRM-System ", heading);
    }

    
    // TEST AGENT WORKFLOW 

    [Given(@"I am logged in as agent and am in the dashboard")]
    public async Task GivenIAmLoggedInAsAgentAndAmInTheDashboard()
    {
        await _page.GotoAsync("http://localhost:3000/dashboard");
    }

    [When(@"I click the navbar and I click requests")]
    public async Task WhenIClickTheNavbarAndIClickRequests()
    {
        await _page.ClickAsync(".navbar-toggler");

        await Task.WhenAll(
            _page.WaitForURLAsync("**/requests"),
            _page.ClickAsync("a.nav-link[href='/requests']")
        );
        
    }

    [When(@"I see the requests I will press join chat")]
    public async Task WhenISeeTheRequestsIWillPressJoinChat()
    {
        
        await _page.WaitForSelectorAsync("tr:has-text('Robotdammsugare')");
        await _page.ClickAsync("tr:has-text('Robotdammsugare') button:has-text('Join')");
        
    }

    [When(@"I will se a chat for specific request")]
    public async Task ThenIWillSeAChatForSpecificRequest()
    {
        var heading = await _page.InnerTextAsync("h4");
        Assert.Equal("Chat", heading);
    }
    
    
    //TEST CHANGE PASSWORD FOR NEW AGENTS
    [Given(@"I am a new agent and I am on the change password page that i recived from my email")]
    public async Task GivenIAmANewAgentAndIAmOnTheChangePasswordPageThatIRecivedFromMyEmail()
    {
        await _page.GotoAsync("http://localhost:3000/changepassword");
    }

    [When(@"I enter ""(.*)"" as existing email")]
    public async Task WhenIEnterAsExistingEmail(string email)
    {
        await _page.FillAsync("input[placeholder='Email']", email);
    }

    [When(@"I enter ""(.*)"" as new password")]
    public async Task WhenIEnterAsNewPassword(string newPassword)
    {
        await _page.FillAsync("input[placeholder='New Password']", newPassword);
    }

    [When(@"I click change password")]
    public async Task WhenIClickChangePassword()
    {
        await Task.WhenAll(
            _page.WaitForSelectorAsync("p:has-text('')"),
            _page.ClickAsync("button:has-text('Change Password')"));
        
    }

    [Then(@"I will get a message below")]
    public async Task ThenIWillGetAMessageBelow()
    {
        
        var heading = await _page.InnerTextAsync("p");
        Assert.Equal("You changed your password!", heading);

    }
    
    [Given(@"I am logged in as admin and I am in the adminpage")]
    public async Task GivenIAmLoggedInAsAdminAndIAmInTheAdminpagen()
    {
        await _page.GotoAsync("http://localhost:3000/adminPage");
    }

    [When(@"I click the navbar and I click on agentlist")]
    public async Task WhenIClickTheNavbarAndIClickOnAgentlist()
    {
        await _page.ClickAsync(".navbar-toggler");

        await Task.WhenAll(
            _page.WaitForURLAsync("**/agentslist"),
            _page.ClickAsync("a.nav-link[href='/agentslist']")
        );
    }
    

    [Then(@"I am on the agentlist page")]
    public async Task ThenIAmOnTheAgentlistPage()
    {
        var heading = await _page.InnerTextAsync("h2");
        Assert.Equal("Add Agent", heading);
    }
    
     
    //TEST IF ADMIN CAN ADD AN AGENT
    [Given(@"I am logged in as admin and I am in the agentlist")]
    public async Task GivenIAmLoggedInAsAdminAndIAmInTheAgentlist()
    {
        await _page.GotoAsync("http://localhost:3000/agentslist");
    }

    [When(@"I enter ""(.*)"" as agents firstname")]
    public async Task WhenIEnterAsAgentsFirstname(string firstname)
    {
        await _page.FillAsync("input[placeholder='Enter agent firstname']", firstname);
    }

    [When(@"I enter ""(.*)"" as agents lastname")]
    public async Task WhenIEnterAsAgentsLastname(string lastname)
    {
        await _page.FillAsync("input[placeholder='Enter agent lastname']", lastname);
    }

    [When(@"I enter ""(.*)"" as agents email")]
    public async Task WhenIEnterAsAgentsEmail(string email)
    {
        await _page.FillAsync("input[placeholder='Enter agent email']", email);
    }

    [When(@"I enter ""(.*)"" as agents password")]
    public async Task  WhenIEnterAsAgentsPassword(string password)
    {
        await _page.FillAsync("input[placeholder='Enter agent password']", password);
    }
    
    [Then(@"I will click Add and the new agent will show up")]
    public async Task ThenIWillClickAddAndTheNewAgentWillShowUp()
    {
        await _page.ClickAsync(".add-button");
        await _page.WaitForSelectorAsync("tbody tr");

    }
    
    //TEST IF ADMIN CAN EDIT AGENT DATA
    [When(@"I press the edit button for specific agent")]
    public async Task WhenIPressTheEditButtonForSpecificAgent()
    {
        await _page.WaitForSelectorAsync("tr:has-text('Bob')");
        await _page.ClickAsync("tr:has-text('Bob') .edit-button");
    }
    
    [Then(@"I want update an agents data to '(.*)','(.*)','(.*)', '(.*)' as press save")]
    public async Task ThenIWantUpdateAnAgentsDataToAsPressSave(string newFirstname, string newLastname, string newEmail, string newPassword)
    {
        var editForm = await _page.QuerySelectorAsync(".EditArea");
        await _page.WaitForSelectorAsync(".EditArea");

        var firstname =  await editForm.QuerySelectorAsync("input[name='firstName']");
        var lastname = await editForm.QuerySelectorAsync("input[name='lastName']");
        var email = await editForm.QuerySelectorAsync("input[name='email']");
        var password = await editForm.QuerySelectorAsync("input[name='password']");

        await firstname.FillAsync(newFirstname);
        await lastname.FillAsync(newLastname);
        await email.FillAsync(newEmail);
        await password.FillAsync(newPassword);

        var saveButton = await editForm.QuerySelectorAsync(".save-button");
        await saveButton.ClickAsync();

    }

    //TEST IF ADMIN CAN DELETE AN AGENT
    [Then(@"I press the delete button for specific agent with email '(.*)'")]
    public async Task WhenIPressTheDeleteButtonForSpecificAgentWithEmail(string email)
    {
        
        await _page.WaitForSelectorAsync($"tr:has-text('{email}')");
        await _page.ClickAsync($"tr:has-text('{email}') .delete-button");
        
    }
    
    //TEST IF ADMIN CAN SE ALL HANDLED AND UNHANDLED REQUESTS AND DELETE ONE
    [When(@"I click the navbar and I click on list and see the list")]
    public async Task WhenIClickTheNavbarAndIClickOnList()
    {
        await _page.ClickAsync(".navbar-toggler");

        await Task.WhenAll(
            _page.WaitForURLAsync("**/list"),
            _page.ClickAsync("a.nav-link[href='/list']")
        );
    }

    [Then(@"I click on delete to remove a handled ärende for ""(.*)""")]
    public async Task ThenIClickOnDeleteToRemoveAHandledArende(string productName)
    {
        await _page.WaitForSelectorAsync($"tr:has-text('{productName}')");
        await _page.ClickAsync($"tr:has-text('{productName}') button:has-text('Delete')");
    }

    
    
    //TEST IF YOU CAN SE A MESSAGE AND IF YOU CAN SEND A MESSAGE IN CHAT.
    [Given(@"I am on the Chat as a agent or customer")]
    public async Task GivenIAmOnTheChatAsAAgentOrCustomer()
    {
        await _page.GotoAsync("http://localhost:3000/chat/1c0fc44d-7eb1-4630-b5fa-3e1e8d699fe9");
    }

    [When(@"I enter ""(.*)"" as my username")]
    public async Task WhenIEnterAsMyUsername(string username)
    {
        await _page.FillAsync("input[placeholder='Enter username']", username);
    }

    [When(@"I enter ""(.*)"" as my message")]
    public async Task WhenIEnterAsMyMessage(string message)
    {
        await _page.FillAsync("input[placeholder='Write your message here']", message);
    }

    [Then(@"I click send and will se my send message")]
    public async Task WhenIClickSend()
    {
        await _page.ClickAsync("button:has-text('Send')");
    }
    
    
    
}