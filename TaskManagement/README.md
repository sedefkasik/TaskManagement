{
  "openapi": "3.0.1",
  "info": {
    "title": "TaskManagement",
    "version": "v1"
  },
  "paths": {
    "/api/TaskHistories": {
      "get": {
        "tags": [
          "TaskHistories"
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/TaskHistory"
                  }
                }
              },
              "application/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/TaskHistory"
                  }
                }
              },
              "text/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/TaskHistory"
                  }
                }
              }
            }
          }
        }
      },
      "post": {
        "tags": [
          "TaskHistories"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/TaskHistory"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/TaskHistory"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/TaskHistory"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/TaskHistory"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/TaskHistory"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/TaskHistory"
                }
              }
            }
          }
        }
      }
    },
    "/api/TaskHistories/{id}": {
      "get": {
        "tags": [
          "TaskHistories"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/TaskHistory"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/TaskHistory"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/TaskHistory"
                }
              }
            }
          }
        }
      },
      "put": {
        "tags": [
          "TaskHistories"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/TaskHistory"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/TaskHistory"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/TaskHistory"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "delete": {
        "tags": [
          "TaskHistories"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    }
  },
  "components": {
    "schemas": {
      "TaskHistory": {
        "type": "object",
        "properties": {
          "id": {
            "type": "integer",
            "format": "int32"
          },
          "reporter": {
            "type": "string",
            "nullable": true
          },
          "title": {
            "type": "string",
            "nullable": true
          },
          "description": {
            "type": "string",
            "nullable": true
          },
          "reportDate": {
            "type": "string",
            "format": "date-time"
          }
        },
        "additionalProperties": false
      }
    }
  }
}
