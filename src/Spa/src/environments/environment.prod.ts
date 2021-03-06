export const environment = {
  production: true,
  apiUrl: 'https://trackerfy-api.azurewebsites.net/api',
  auth: {
    domain: 'trackerfy.us.auth0.com',
    clientId: 'PJhl8w04c6MrpWfmwOifNzkYPDi9EarR',
    audience: 'https://trackerfy-api.azurewebsites.net/',
    redirect: 'https://trackerfy.azurewebsites.net/callback',
    appUrl: 'https://trackerfy.azurewebsites.net',
    scope: 'openid profile email'
  }
};
