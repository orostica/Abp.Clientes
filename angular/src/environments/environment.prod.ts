import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44328/',
  redirectUri: baseUrl,
  clientId: 'Clientes_App',
  responseType: 'code',
  scope: 'offline_access Clientes',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Clientes',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44328',
      rootNamespace: 'Abp.Clientes',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
