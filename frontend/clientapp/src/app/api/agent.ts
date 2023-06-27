import axios, { AxiosResponse } from "axios";
import { Activity } from "../layout/models/Activity";

const sleep = (delay: number) => {
  return new Promise((resolve) => {
    setTimeout(resolve, delay);
  });
};

axios.defaults.baseURL = "http://localhost:5261/api";

axios.interceptors.response.use(async (response) => {
  try {
    await sleep(1000);
    return response;
  } catch (error) {
    console.log(error);
    return await Promise.reject(error);
  }
});

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
  details: (id: string) => request.get<void>(`/activities/${id}`),
  create: (activity: Activity) => request.post<void>("/activities", activity),
  update: (activity: Activity) =>
    request.put<void>(`/activities/${activity.id}`, activity),
  delete: (id: string) => request.delete<void>(`/activities/${id}`),
};
const agent = {
  Activities,
};
export default agent;
