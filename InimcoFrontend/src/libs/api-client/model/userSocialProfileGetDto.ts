/**
 * My Title
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */
import { SocialMediaAccountGetDto } from './socialMediaAccountGetDto';


export interface UserSocialProfileGetDto { 
    firstName: string;
    lastName: string;
    socialSkills: Array<string>;
    socialMediaAccounts: Array<SocialMediaAccountGetDto>;
    vowelsInName: number;
    consonantInName: number;
    reversedName: string;
}

