import axios, { AxiosResponse } from "axios";
import { Activity } from "../layout/models/Activity";

axios.defaults.baseURL = "http://localhost:5261/api";

const responseBody = <T>(response: AxiosResponse<T>) => response.data;

const request = {
  get: async <T>(url: string) => {
    var response = await axios.get<T>(url);
    return responseBody(response);
  },
  post: async <T>(url: string, body: {}) => {
    var response = await axios.post<T>(url, body);
    return responseBody(response);
  },
  put: async <T>(url: string, body: {}) => {
    var response = await axios.put<T>(url, body);
    return responseBody(response);
  },
  delete: async <T>(url: string) => {
    var response = await axios.delete<T>(url);
    return responseBody(response);
  },
};

const Activities = {
  fetchlist: () => request.get<Activity[]>("/activities"),
};
const agent = {
  Activities,
};
export default agent;
